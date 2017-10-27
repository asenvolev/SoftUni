package ReverseCharacters;


import java.util.Scanner;

public class ReverseCharacters {
    public static void main(String[] args){
        Scanner scan = new Scanner(System.in);
        String first = scan.nextLine();
        String second = scan.nextLine();
        String third = scan.nextLine();
        String split = third+second+first;
        System.out.print(split);
    }

}
