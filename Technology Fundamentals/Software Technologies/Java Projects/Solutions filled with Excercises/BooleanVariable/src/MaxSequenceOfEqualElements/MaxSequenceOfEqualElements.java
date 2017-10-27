package MaxSequenceOfEqualElements;

import java.util.Arrays;
import java.util.Scanner;

public class MaxSequenceOfEqualElements {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);
        int[] arr = Arrays.stream(scan.nextLine().split(" ")).mapToInt(Integer::parseInt).toArray();
//        int[] currArr = new int[arr.length];

        int currentLength = 1;
        int bestLength = 1;
        int mostFrequentNum = 0;
        int curr = 0;
        int prev = 0;
        for (int i = 1; i < arr.length; i++) {
            curr = arr[i];
            prev = arr[i - 1];

            if (curr == prev) {
                currentLength++;
            } else {
                if (currentLength > bestLength) {
                    bestLength = currentLength;
                    mostFrequentNum = prev;
                }

                currentLength = 1;
            }
        }

        if (currentLength > bestLength) {
            bestLength = currentLength;
            mostFrequentNum = prev;
        }

        for (int i = 0; i < bestLength; i++) {
            System.out.print(mostFrequentNum + " ");

        }
    }
}
