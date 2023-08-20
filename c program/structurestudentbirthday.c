#include<stdio.h>
#include<string.h>
struct student
{
	int rollno;
	char name[20];
	struct date
	{
		int date;
		int month;
		int year;
	}
	birthdate,adddate;
};
void main()
{
	struct student stud[3];
	int counter,a;
	for(counter=0;counter<3;counter++)
	{
		printf("enter rollno.,name :");
		scanf("%d%s",&stud[counter].rollno,&stud[counter].name);
		printf("enter birthday :");
		scanf("%d-%d-%d",&stud[counter].birthdate.date,&stud[counter].birthdate.month,&stud[counter].birthdate.year);
		printf("addmission date :");
		scanf("%d-%d-%d",&stud[counter].adddate.date,&stud[counter].adddate.month,&stud[counter].adddate.year);
	}
	for(counter=0;counter<3;counter++)
	{
		a=stud[counter].adddate.year-stud[counter].birthdate.year;	
	printf("\nage of student at the time of addmission :");
		printf("\t%d years",a);
	}
}




//Algorithm:
//	1)start
//	2)define structure student
//	3)declare rollno,name,date,month,year
//	4)create an array of structure student with size 3
//	5)for counter=0,counter<3,counter++
//	6)accept roll no,name,birthday,addmission date
//	7)a=addate.year-birthdate.year
//	8)print age of student at the time of addmission
//	9)stop


	
	

