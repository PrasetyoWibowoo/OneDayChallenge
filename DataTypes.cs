        // Declare second integer, double, and String variables.
        int secondInteger;
        double secondDouble;
        string secondString;
        
        // Read and save an integer, double, and String to your variables.
        secondInteger = Convert.ToInt32(Console.ReadLine());
        secondDouble = Convert.ToDouble(Console.ReadLine());
        secondString = Console.ReadLine();
        
        // Print the sum of both integer variables on a new line.
        Console.WriteLine(i + secondInteger);
        
        // Print the sum of the double variables on a new line.
        Console.WriteLine((d + secondDouble).ToString("F1"));
                
        // Concatenate and print the String variables on a new line
        // The 's' variable above should be printed first.
        Console.WriteLine(s + secondString);
