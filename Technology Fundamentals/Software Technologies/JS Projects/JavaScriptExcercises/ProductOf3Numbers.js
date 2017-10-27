function func(nums) {
    let positive = 0;
    let negative = 0;
    for (let i = 0; i < nums.length; i++) {
         if (Number(nums[i])>0)
         {
             positive++;
         }
         else
         {
             negative++;
         }
    }
    if (positive%2===0)
    {
        console.log('Negative');
    }
    else
    {
        console.log('Positive');
    }
}