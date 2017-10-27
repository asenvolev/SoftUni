package IntegerToHexAndBinary;


import java.util.Scanner;

public class IntegerToHexAndBinary {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);
        int num = scan.nextInt();
        String HexRes = Integer.toHexString(num);
        String BinRes = Integer.toBinaryString(num);
        System.out.println(HexRes.toUpperCase());
        System.out.println(BinRes);

    }

}
