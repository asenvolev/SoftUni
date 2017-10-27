package com.company;

import java.util.Scanner;

public class Main {

    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);
        String first = scan.nextLine();
        if (first.contentEquals("True")){
            System.out.print("Yes");
        }
        else{
            System.out.print("No");
        }

    }
}
