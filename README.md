# cm-questions

### Prerequisites

To run this project on your local machine, you will need:

```
Visual Studio 2019 Version 16.4 or higher
```
```
.NET Core 3.1 SDK (or lower if you choose to point the project to another version of .NET Core, like 2.1 for example
```

### Other Considerations

* This VS Solution includes a .NET Core 3.1 Console Project and a .NET Core 3.1 XUnit Test Project
* No interface is provided (except for Question 8) to execute the different classes and its methods in this solution but by debugging the UTs those methods can be analysed.

### Question2

* Assumption: if the input is negative, the function returns null

### Question3

* Assumption: Only three different types of triangle exist: Equilateral, Isosceles and Scalene

### Question5

* An SQL Server DB Version 15.0 (2019) has been used to help answer this question 
* Microsoft QL Server Management Studio was used to run queries on the DB

### Question8

* Through the Interface in the Console Project, it is possible to see how the solution of this question executes. 
* When you run the project, you will see how the Class used to answer this question is executed by pointing to the following URL: [Microsoft News site](https://news.microsoft.com/en-au/)
* All links within that link will be extracted and then a GET requests will be sent against those links to and the responses stored.
* As the requests are happening, you will see in the command line the result of this request with the following format:
```
URL Processed | ElapsedTime: 383 ms | Result: OK | Url: https://azure.microsoft.com/en-au/
```
* Finally, at the end of the execution more information like: links processed, successful links, not successful links and total elapsed time will be provided
* Assumptions: Any response other than OK (200) is considered to be a not successful response

## Online Resources

* [Regular Expressions 101](https://regex101.com/) - For testing the Regex used in Question 8
* [ROW_NUMBER (Transact-SQL)](https://docs.microsoft.com/en-us/sql/t-sql/functions/row-number-transact-sql?view=sql-server-ver15) - For assisting on providing ane of the answers for question 5
* [Kahn Academy)](https://www.khanacademy.org/math/basic-geo/basic-geo-area-and-perimeter/area-triangle/a/area-of-triangle) - For providing information on calculating the are of triangles

## Authors

* **Luis Del Valle** 
