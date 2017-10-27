package VowelOrDigit;
import java.util.Scanner;

public class VowelOrDigit {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);
        char input = scan.nextLine().charAt(0);

        boolean isDigit = Character.isDigit(input);
        boolean isVowel = false;

        if (isDigit) {
            System.out.println("digit");
        } else {
            if ((input == 'a') ||
                    (input == 'e') ||
                    (input == 'i') ||
                    (input == 'o') ||
                    (input == 'u')) {
                isVowel = true;
            }

            if (isVowel) {
                System.out.println("vowel");
            } else {
                System.out.println("other");
            }
        }

    }
}