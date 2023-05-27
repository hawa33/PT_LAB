/*WAP to ask user a number and check if it is odd, even or zero. */
import java.util.Scanner;
public class Qn3 {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);        
        System.out.print("Enter a number: ");
        int number = scanner.nextInt();        
        if (number == 0) {
            System.out.println("The number is zero.");
        } else if (number % 2 == 0) {
            System.out.println("The number is even.");
        } else {
            System.out.println("The number is odd.");
        }
        scanner.close();
    }
}
