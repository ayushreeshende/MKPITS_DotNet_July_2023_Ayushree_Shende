#include<stdio.h>
#include<string.h>
struct employee
{
	int employeeid;
	char designation[20];
	char department[20];
	int salary;
	char name[20];
	
};
void main()
{
	struct employee emp[5];
	int counter;
	for(counter=0;counter<5;counter++)
	{
		printf("enter employee id,name,designation,department,salary");
		scanf("%d",&emp[counter].employeeid);
		scanf("%s",&emp[counter].name);
		scanf("%s",&emp[counter].designation);
		scanf("%s",&emp[counter].department);
		scanf("%d",&emp[counter].salary);
	}
	printf("\nemployee details\n");
	for(counter=0;counter<5;counter++)
	{
		printf("\nemployee id=%d\t",emp[counter].employeeid);
		printf("name=%s\t",emp[counter].name);
		printf("designation=%s\t",emp[counter].designation);
		printf("department=%s\t",emp[counter].department);
		printf("salary=%d\t",emp[counter].salary);
	}
}



//Algorithm:
//	1)start                                                          
//	2)define structure employee
//	3)declare employeeid,designation,salary,department,name,counter
//	4)create an array of employee size with 5
//	5)for counter=0,counter<5,counter++
//	6)accept employeeid,designation,salary,name,department
//	7)print employee details
//	8)stop 
