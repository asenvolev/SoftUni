namespace ProductsShop
{
    using System;
    using System.IO;
    using System.Linq;

    using Newtonsoft.Json;
    using ProductsShop.Data;
    using ProductsShop.Models;
    using System.Collections.Generic;
    using System.Xml.Linq;

    public class StartUp
    {
        public static void Main()
        {
            GetUsersAndProducts();
        }

        public static void GetUsersAndProducts()
        {
            using (var context = new ProductsShopContext())
            {
                var sellers = context.Users
                    .Where(u => u.ProductsSold.Any(p => p.Buyer != null))
                    .OrderByDescending(u => u.ProductsSold.Count(x => x.Buyer != null))
                    .ThenBy(u => u.LastName)
                    .Select(u => new
                    {
                        firstName = u.FirstName,
                        lastName = u.LastName,
                        age = u.Age,
                        soldProducts = u.ProductsSold.Where(p => p.Buyer != null).Select(p => new
                        {
                            name = p.Name,
                            price = p.Price
                        }).ToList()
                    }).ToArray();

                var xmlDoc = new XDocument(new XElement("users",new XAttribute("count",sellers.Count())));

                foreach (var seller in sellers)
                {
                    if (seller.age == null)
                    {
                        xmlDoc.Root.Add(new XElement("user",
                        new XAttribute("first-name", seller.firstName == null ? string.Empty : seller.firstName),
                        new XAttribute("last-name", seller.lastName),
                        new XElement("sold-products", new XAttribute("count", seller.soldProducts.Count())
                        )));
                    }
                    else
                    {
                        xmlDoc.Root.Add(new XElement("user",
                        new XAttribute("first-name", seller.firstName == null ? string.Empty : seller.firstName),
                        new XAttribute("last-name", seller.lastName),
                        new XAttribute("age", seller.age),
                        new XElement("sold-products", new XAttribute("count", seller.soldProducts.Count())
                        )));
                    }

                    foreach (var prod in seller.soldProducts)
                    {
                        xmlDoc.Root.Elements("user").Last().Element("sold-products").Add(new XElement("product", new XAttribute("name", prod.name), new XAttribute("price", prod.price)));
                    }
                }

                File.WriteAllText("UsersAndProductsXml.xml", xmlDoc.ToString());
            }
        }

        public static void GetCategoriesByProductCountXml()
        {
            using (var context = new ProductsShopContext())
            {
                var categories = context.Categories
                    .OrderBy(c => c.Products.Count)
                    .Select(c => new
                    {
                        categoryName = c.Name,
                        productsCount = c.Products.Count,
                        averagePrice = c.Products.Sum(x => x.Product.Price) / c.Products.Count,
                        totalRevenue = c.Products.Sum(x => x.Product.Price)
                    }).ToArray();

                var xmlDoc = new XDocument(new XElement("categories"));

                foreach (var cat in categories)
                {
                    xmlDoc.Root.Add(new XElement("category",
                        new XAttribute("name", cat.categoryName),
                        new XElement("products-count", cat.productsCount),
                        new XElement("average-price", cat.averagePrice),
                        new XElement("total-revenue", cat.totalRevenue)
                        ));
                }

                File.WriteAllText("GetCategoriesByProductCountXml.xml", xmlDoc.ToString());
            }
        }

        public static void SoldProductsXml()
        {
            using (var context = new ProductsShopContext())
            {
                var sellers = context.Users
                    .Where(u => u.ProductsSold.Any(p => p.Buyer != null))
                    .OrderBy(u => u.LastName)
                    .ThenBy(u => u.FirstName)
                    .Select(u => new
                    {
                        firstName = u.FirstName,
                        lastName = u.LastName,
                        soldProducts = u.ProductsSold.Where(p=>p.Buyer!=null).Select(p => new
                        {
                            name = p.Name,
                            price = p.Price
                        }).ToList()
                    }).ToArray();

                var xmlDoc = new XDocument(new XElement("users"));
                
                foreach (var seller in sellers)
                {
                    xmlDoc.Root.Add(new XElement("user",
                        new XAttribute("first-name", seller.firstName==null ? string.Empty:seller.firstName),
                        new XAttribute("last-name", seller.lastName),
                        new XElement("sold-products",null
                        )));

                    foreach (var prod in seller.soldProducts)
                    {
                        xmlDoc.Root.Elements("user").Last().Element("sold-products").Add(new XElement("product", new XElement("name", prod.name), new XElement("price", prod.price)));
                    }
                }

                File.WriteAllText("SoldProductsXml.xml", xmlDoc.ToString());
            }
        }

        public static void ProductsInRangeXmlExport()
        {
            using (var context = new ProductsShopContext())
            {
                var productsInRange = context.Products
                    .Where(p => p.Price >= 1000 && p.Price <= 2000 && p.Buyer!=null)
                    .OrderBy(x => x.Price)
                    .Select(p => new
                    {
                        name = p.Name,
                        price = p.Price,
                        buyer = $"{p.Buyer.FirstName} {p.Buyer.LastName}"
                    }).ToArray();

                var xDoc = new XDocument(new XElement("products"));

                foreach (var prod in productsInRange)
                {
                    xDoc.Root.Add(new XElement("product",
                        new XAttribute("name", prod.name),
                        new XAttribute("price", prod.price),
                        new XAttribute("buyer", prod.buyer)
                        ));
                }

                string result = xDoc.ToString();

                File.WriteAllText("ProductsInRangeXmlExport.xml", result);
            }
        }

        public static string ImportCategoriesFromXml()
        {
            string path = @"..\Resources\categories.xml";

            string xmlString = File.ReadAllText(path);

            var xmlDoc = XDocument.Parse(xmlString);

            var categories = new List<Category>();

            foreach (var elem in xmlDoc.Root.Elements())
            {
                string name = elem.Element("name").Value;
                var category = new Category()
                {
                    Name = name,
                };
                categories.Add(category);
            }
            using (var context = new ProductsShopContext())
            {
                context.Categories.AddRange(categories);
                context.SaveChanges();
            }

            return $"{categories.Count} categories were imported from {path}";
        }

        public static string ImportProductsFromXml()
        {
            string path = @"..\Resources\products.xml";

            string xmlString = File.ReadAllText(path);

            var xmlDoc = XDocument.Parse(xmlString);

            var rnd = new Random();

            var validProducts = new List<Product>();

            var elements = xmlDoc.Root.Elements();

            using (var context = new ProductsShopContext())
            {
                var userIds = context.Users.Select(u => u.Id).ToArray();

                foreach (var elem in elements)
                {
                    int sellerId = userIds[rnd.Next(0, userIds.Length)];

                    int buyerId = sellerId;

                    while (buyerId == sellerId)
                    {
                        buyerId = userIds[rnd.Next(0, userIds.Length)];
                    }

                    string name = elem.Element("name")?.Value;
                    decimal price = decimal.Parse(elem.Element("price").Value);

                    var product = new Product()
                    {
                        Name = name,
                        Price = price,
                        BuyerId = buyerId,
                        SellerId = sellerId
                    };

                    validProducts.Add(product);
                }


                context.Products.AddRange(validProducts);
                context.SaveChanges();
            }

            return $"{validProducts.Count} products were imported from {path}";
        }

        public static string ImportUsersFromXml()
        {
            string path = @"..\Resources\users.xml";

            string xmlString = File.ReadAllText(path);

            var xmlDoc = XDocument.Parse(xmlString);

            var users = new List<User>();

            foreach (var elem in xmlDoc.Root.Elements())
            {
                string firstName = elem.Attribute("firstName")?.Value;
                string lastName = elem.Attribute("lastName")?.Value;
                int? age = null;

                if (elem.Attribute("age") != null)
                {
                    age = int.Parse(elem.Attribute("age").Value);
                }

                var user = new User()
                {
                    FirstName = firstName,
                    LastName = lastName,
                    Age = age
                };

                users.Add(user);
            }

            using (var context = new ProductsShopContext())
            {
                context.Users.AddRange(users);
                context.SaveChanges();
            }

            return $"{users.Count} users were imported from {path}";
        }

        public static void UsersAndProducts()
        {
            using (var context = new ProductsShopContext())
            {
                var sellers = context.Users
                    .Where(u => u.ProductsSold.Any(p => p.Buyer != null))
                    .OrderByDescending(u => u.ProductsSold.Count(x=>x.Buyer!=null))
                    .ThenBy(u => u.LastName)
                    .Select(u => new
                    {
                        firstName = u.FirstName,
                        lastName = u.LastName,
                        age = u.Age,
                        soldProducts = u.ProductsSold.Where(p=>p.Buyer!=null).Select(p => new
                        {
                            name = p.Name,
                            price = p.Price
                        })
                    }).ToArray();

                var jsonString = JsonConvert.SerializeObject(sellers, Formatting.Indented, new JsonSerializerSettings()
                {
                    DefaultValueHandling = DefaultValueHandling.Ignore
                });

                File.WriteAllText("UsersAndProducts.json", jsonString);
            }
        }

        public static void CategoriesByProductCountJson()
        {
            using (var context = new ProductsShopContext())
            {
                var categories = context.Categories
                    .OrderBy(c=>c.Name)
                    .Select(c => new
                    {
                        categoryName = c.Name,
                        productsCount = c.Products.Count,
                        averagePrice = c.Products.Sum(x=>x.Product.Price) / c.Products.Count,
                        totalRevenue = c.Products.Sum(x => x.Product.Price)
                    }).ToArray();

                var jsonString = JsonConvert.SerializeObject(categories, Formatting.Indented);

                File.WriteAllText("CategoriesByProductCount.json", jsonString);
            }
        }

        public static void SoldProductsJson()
        {
            using (var context = new ProductsShopContext())
            {
                var sellers = context.Users
                    .Where(u => u.ProductsSold.Any(p=>p.Buyer!=null))
                    .OrderBy(u => u.LastName)
                    .ThenBy(u=>u.FirstName)
                    .Select(u => new
                    {
                        firstName = u.FirstName,
                        lastName = u.LastName,
                        soldProducts = u.ProductsSold.Select(p => new
                        {
                            name = p.Name,
                            price = p.Price,
                            buyerFirstName = p.Buyer.FirstName,
                            buyerLastName = p.Buyer.LastName
                        })
                    }).ToArray();

                var jsonString = JsonConvert.SerializeObject(sellers, Formatting.Indented, new JsonSerializerSettings()
                {
                    DefaultValueHandling = DefaultValueHandling.Ignore
                });

                File.WriteAllText("SoldProducts.json", jsonString);
            }
        }

        public static void ProductsInRangeJson()
        {
            using (var context = new ProductsShopContext())
            {
                var productsInRange = context.Products
                    .Where(p => p.Price >= 500 && p.Price <= 1000)
                    .OrderBy(x => x.Price)
                    .Select(p => new
                    {
                        name = p.Name,
                        price = p.Price,
                        seller = $"{p.Seller.FirstName} {p.Seller.LastName}"
                    }).ToArray();

                var jsonString = JsonConvert.SerializeObject(productsInRange, Formatting.Indented);

                File.WriteAllText("ProductsInRange.json", jsonString);
            }
        } 

        public static void SetRandomCategoriesToProducts()
        {
            using (var context = new ProductsShopContext())
            {
                var categories = context.Categories.Select(c => c.Id).ToArray();

                var products = context.Products.Select(x => x.Id).ToArray();

                var validCategoryProducts = new List<CategoryProduct>();

                var rnd = new Random();

                var lastRandom = 0;

                foreach (var p in products)
                {
                    int newRandom = rnd.Next(0, categories.Length);
                    while (lastRandom == newRandom)
                    {
                        newRandom = rnd.Next(0, categories.Length);
                    }
                    lastRandom = newRandom;
                    var catProd = new CategoryProduct()
                    {
                        CategoryId = categories[lastRandom],
                        ProductId = p
                    };

                    if (!validCategoryProducts.Any(c=>c.CategoryId == catProd.CategoryId && c.ProductId == catProd.ProductId))
                    {
                        validCategoryProducts.Add(catProd);
                    }
                }

                context.CategoryProducts.AddRange(validCategoryProducts);
                context.SaveChanges();
            }
        } 

        public static string ImportCategoryFromJson()
        {
            string path = @"..\Resources\categories.json";
            Category[] categories = ImprotJson<Category>(path);

            using (var context = new ProductsShopContext())
            {
                context.Categories.AddRange(categories);
                context.SaveChanges();
            }

            return $"{categories.Length} categories were imported from {path}";
        }

        public static string ImportProductsFromJson()
        {
            string path = @"..\Resources\products.json";
            Product[] products = ImprotJson<Product>(path);

            var rnd = new Random();

            using (var context = new ProductsShopContext())
            {
                var userIds = context.Users.Select(u => u.Id).ToArray();
                
                foreach (var product in products)
                {
                    int sellerId = userIds[rnd.Next(0, userIds.Length)];

                    int buyerId = sellerId;

                    while (buyerId == sellerId)
                    {
                        buyerId = userIds[rnd.Next(0, userIds.Length)];
                    }
                    product.SellerId = sellerId;
                    product.BuyerId = buyerId;
                }
                context.Products.AddRange(products);
                context.SaveChanges();
            }

            return $"{products.Length} products were imported from {path}";
        }

        public static string ImportUsersFromJson()
        {
            string path = @"..\Resources\users.json";
            User[] users = ImprotJson<User>(path);

            using (var context = new ProductsShopContext())
            {
                context.Users.AddRange(users);
                context.SaveChanges();
            }

            return $"{users.Length} users were imported from {path}";
        }

        public static T[] ImprotJson<T>(string path)
        {
            string jsonString = File.ReadAllText(path);

            T[] objects = JsonConvert.DeserializeObject<T[]>(jsonString);

            return objects;
        }
    }
}
