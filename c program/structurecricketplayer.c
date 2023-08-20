#include<stdio.h>
#include<string.h>
struct cricket
{
int run; 
char name[20];
	
};
void main()
{
	struct cricket cr[11];
	int counter;
	int total=0;
	for(counter=0;counter<11;counter++)
	{
		printf("enter player nam & their runs :");
		scanf("%s%d",&cr[counter].name,&cr[counter].run);
	}
	printf("\nenter scorecard details:");
	for(counter=0;counter<11;counter++)
	{
		printf("\nname=%s\t",cr[counter].name);
		scanf("runs=%d\t",cr[counter].run);
	}
	for(counter=0;counter<11;counter++)
	{
	total=total+cr[counter].run;
}
printf("\n total runs of team=%d",total);
	}
	
	
//	Algorithm:
//		1)start
//		2)define structure cricket
//		3)declare run,name,counter,total
//		4)create an array of structure of cricket with size11
//		5)for counter=0,counter<11,counter++
//		6)accept player name , runs and scorecard details
//		7)total=total+cricket.run
//		8)print total runs of team
//		9)stop
