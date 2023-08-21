#include<stdio.h>
struct worker
{
     char name[20];
     int wage;
     int wdays;
     int sal;
};
int main()
{
     struct worker work[2];
     int wage,wdays,sal;
     int counter;
     for(counter=0;counter<2;counter++)
     {
     	printf("enter worker and wage and working days:");
     	scanf("%s%d%d",&work[counter].name,&work[counter].wage,&work[counter].wdays);
	 }
	 for(counter=0;counter<2;counter++)
	 {
	 	work[counter].sal=work[counter].wage*work[counter].wdays;
	 	
	 }
for(counter=0;counter<2;counter++)
{
	printf("\n total salary=%d",work[counter].sal);
}
}



//Algorithm:
//	1)start
//	2)define structure worker
//	3)declare name,wage,wdays,salary,counter
//	4)create an array ofstructure worker work with size 2
//	5)for counter=0,counter<2,counter++
//	6)accept worker name,wage,workinG DAYS
//	7)WORker salary=worker wage*/working days
//	8)print total salary
//	9)stop
	
