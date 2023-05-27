/*WAP to ask user a number and print if it is a positive. */
import java.util.Scanner;
public class Qn1 {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        System.out.print("Enter a number: ");
        int number = scanner.nextInt();
        if (number > 0) {
            System.out.println("The number is positive.");
        } else {
            System.out.println("The number is not positive.");
        }
        scanner.close();
    }
}
