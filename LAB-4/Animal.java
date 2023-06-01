// Parent class
class Animal {
    void eat() {
        System.out.println("The animal is eating.");
    }
}
// Child class inheriting from the parent class
class Dog extends Animal {
    void bark() {
        System.out.println("The dog is barking.");
    }
}
// Child class inheriting from the parent class
class Cat extends Animal {
    void meow() {
        System.out.println("The cat is meowing.");
    }
}
public class Main {
    public static void main(String[] args) {
        // Create an object of the Dog class
        Dog dog = new Dog();
        // Call methods from the Dog class
        dog.eat();
        dog.bark();
        // Create an object of the Cat class
        Cat cat = new Cat();
        
        // Call methods from the Cat class
        cat.eat();
        cat.meow();
    }
}
