/*WAP to print the maximum number from list of number 5,10,11,6,8,9 using for each loop.*/
public class Qn6 {
    public static void main(String[] args) {
        int[] numbers = {5, 10, 11, 6, 8, 9};
        int maximum = numbers[0];
        for (int number : numbers) {
            if (number > maximum) {
                maximum = number;
            }
        }
        System.out.println("The maximum number is: " + maximum);
    }
}

