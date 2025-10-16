void add(string studentName, List<string> studentnames )
{
    studentnames.Add(studentName);
}

List <string> studentNames = new List<string>();

add("Marcel", studentNames);
add("John", studentNames);
add("Jane", studentNames);
add("Vasile", studentNames);

Console.WriteLine(String.Join("," , studentNames));


    
