#include<stdio.h>
#include<string.h>
struct student
{
	int rollno;
	char name[20];
};
void main()
{
	struct student stud[5];
	int counter;
	for(counter=0;counter<5;counter++)
	{
		printf("enter roll no and name");
		scanf("%d",&stud[counter].rollno);
		scanf("%s",&stud[counter].name);
		
			}
			printf("\n student details");
			for(counter=0;counter<5;counter++)
			{
				printf("\n rollno=%d",stud[counter].rollno);
				printf("\n name=%s",stud[counter].name);
			}
}


//Algorithm:
//	1)start
//	2)define structure student
//	3)declare name,rollno,counter
//	4)create an array of structure student with size 5
//	5)  counter=0,counter<5,counter++
//	6)accept rollno,name,student detail
//	7)print rollno and name
//	8)stop
