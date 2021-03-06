// CS0136: A local variable named `t' cannot be declared in this scope because it would give a different meaning to `t', which is already used in a `parent or current' scope to denote something else
// Line: 15
using System;

public delegate void Hello (Test test);

public class Test
{
	public void Whatever ()
	{ }

	static void RunIt (Test t)
	{
		Hello hello = delegate (Test test) {
			Test t = test;
			t.Whatever ();
		};
		hello (t);
	}

	static void Main ()
	{
		Test t = new Test ();
		RunIt (t);
	}
}
