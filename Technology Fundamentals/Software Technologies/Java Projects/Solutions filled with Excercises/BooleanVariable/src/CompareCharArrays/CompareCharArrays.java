package CompareCharArrays;

import java.util.Arrays;
import java.util.Scanner;

public class CompareCharArrays {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);
        String[] firstStr = scan.nextLine().split(" ");
        String[] secondStr = scan.nextLine().split(" ");
        int lenght = Math.min(firstStr.length, secondStr.length);
        for (int i = 0; i < lenght; i++) {
            if (firstStr[i].equals(secondStr[i])) {
                if (i==lenght-1){
                    if (firstStr.length <= secondStr.length) {
                        System.out.println(String.join("", firstStr));
                        System.out.println(String.join("", secondStr));
                    }
                    else {
                        System.out.println(String.join("", secondStr));
                        System.out.println(String.join("", firstStr));
                    }
                }
                continue;
            }
            else if (firstStr[i].charAt(0) < secondStr[i].charAt(0)) {
                System.out.println(String.join("", firstStr));
                System.out.println(String.join("", secondStr));
                break;
            }
            else
            {
                System.out.println(String.join("", secondStr));
                System.out.println(String.join("", firstStr));
                break;
            }
        }
    }

}
