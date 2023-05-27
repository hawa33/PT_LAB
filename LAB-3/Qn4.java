/*WAP to ask user a number and print its multiplication table using while loop do while loop and for loop. */
import java.util.Scanner;
public class Qn4 {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        System.out.print("Enter a number: ");
        int number = scanner.nextInt();
        System.out.println("Multiplication Table using while loop:");
        int i = 1;
        while (i <= 10) {
            System.out.println(number + " x " + i + " = " + (number * i));
            i++;
        }
        System.out.println("Multiplication Table using do-while loop:");
        int j = 1;
        do {
            System.out.println(number + " x " + j + " = " + (number * j));
            j++;
        } while (j <= 10);
        System.out.println("Multiplication Table using for loop:");
        for (int k = 1; k <= 10; k++) {
            System.out.println(number + " x " + k + " = " + (number * k));
        }
        scanner.close();
    }
}
