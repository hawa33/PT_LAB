class Person {
	// data members of the class.
	String name;
	int id;
	Person(String name, int id)
	{
		this.name = name;
		this.id = id;
	}
}
class GFG {
	public static void main(String[] args)
	{
		// This would invoke constructor.
		Person person1 = new Person("avinash", 68);
		System.out.println("Name :" + person1.name
						+ " andId :" + person1.id);
	}
}
