# cm-questions

Hi CampaignMonitor team. This project has been created to provide answers for questions 1, 2, 3, 4, 5 and 8 of the Coding Take-Home test and as part of my application for a Full Stack Software Engineer role in CM. In the sections below you will find any comments and assumptions for some of the questions. Thank you for the chance to solve this test.
Luis Del Valle
0452523942
luis@luis-delvalle.com


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

### Question5

* An SQL Server DB Version 15.0 (2019) has been used to help answer this question 
* Microsoft QL Server Management Studio was used to run queries on the DB

### Question8

* Through the Interface in the Console Project, it is possible to see how the solution of this question executes. 
* When you run the project, you will see how the Class used to answer this question is executed by pointing to the following URL: [Microsoft News site](https://news.microsoft.com/en-au/)
* All links within that link will be extracted and then a GET requests will be sent against those links to and the responses stored.
* As the requests are happening, you will see in the command line the result of this request with the following format:

Example:
```
URL Processed | ElapsedTime: 383 ms | Result: OK | Url: https://azure.microsoft.com/en-au/
```

## Online Resources

* [Regular Expressions 101](https://regex101.com/) - For testing the Regex used in Question 8
* [ROW_NUMBER (Transact-SQL)](https://docs.microsoft.com/en-us/sql/t-sql/functions/row-number-transact-sql?view=sql-server-ver15) - For assisting on providing ane of the answers for question 5
* [Kahn Academy)](https://www.khanacademy.org/math/basic-geo/basic-geo-area-and-perimeter/area-triangle/a/area-of-triangle) - For providing information on calculating the are of triangles

## Authors

* **Luis Del Valle** 

## License

This project is licensed under the MIT License

## Acknowledgments

* Hat tip to anyone whose code was used
* Inspiration
* etc
