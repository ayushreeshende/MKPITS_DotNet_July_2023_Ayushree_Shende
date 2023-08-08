#include<stdio.h>
#include<string.h>
struct fees
{
	char name[20];
	int fees,month,per_day;
};
void main()
{
	struct student stud[3];
	int fees,month,hours,per_day,per_hours;
	int counter;
	for(counter=0;counter<3;counter++)
	{
		printf("enter name and fees :");
		scanf("%s%d",&stud[counter].name,&stud[counter].fees);
	}
	for(counter=0;counter<3;counter++)
	{
		month=20*3;
		hours=8;
		per_day=stud[counter].fees/month;
		per_hours=per_day/8;
		printf("\nper_day=%d",per_day);
		printf("\nper _hours=%d",per_hours);
	}
}

		
//	Algorithm:
//		1)start
//		2)define struct fees
//		3)declare int fees,month,perday,name,hours,per_hours
//		4)create an array of structure student with size3
//		5)for counter=0,counter<3,counter++
//		6)accept name and fees
//		7)month=20*3 & hrs=8
//		8)perhrs=perday/8
//		9)perday& perhrs
//		10)stop
		
		
		
		
		
		
		
		
		
		
		
	
