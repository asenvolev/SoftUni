package com.company;

import java.util.Scanner;

public class Main {

    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);
        String num = scan.nextLine();
        int result = Integer.parseInt(num,16);
        System.out.print(result);
    }
}
