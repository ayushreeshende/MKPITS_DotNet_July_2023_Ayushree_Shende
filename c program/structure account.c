

#include<stdio.h>
#include<string.h>
struct bank
{
	char name[20];
	int acc_no,balance;
};

void print(struct bank b1[3])
{
int counter;
printf("\naccount with balance minimum less than 100");
	for(counter=0;counter<3;counter++)
{
if(b1[counter].balance<100)
{
	printf("\nname=%s and balance=%d",b1[counter].name,b1[counter].balance);
}
}
}
void main()
{
	struct bank b1[3];
	int counter;
	for(counter=0;counter<3;counter++)
	{
		printf("name account no and balance:");
		scanf("%s%d%d",b1[counter].name,&b1[counter].acc_no,&b1[counter].balance);
	}
	print(b1);
}



//Algorithm:
//	1)start
//	2)define structure bank
//	3)declare name,account no,balance,counter
//	4)create an array of structure bank b1 with size3
//	5)loop from counter=0,counter<3,counter++
//	6)accept accountno and balance
//	7)balance<100 
//	8)print name and bal
//	9)stop























































	

