#include<stdio.h>
void prime(int num,int counter,int rem)
{
		while(counter<num)
		{
	 rem=num%counter;
	 if(rem==0)
{

	printf("not a prime no");
	break;
	
}
counter=counter+1;
}
if(num==counter)
{
printf("it is not a prime no");
}
}

void main()
{

	int num,counter=2,rem=0;
	printf("enter num");
	scanf("%d",&num);
	prime(num,counter,rem);
	
}


//Algorithm:
//	1)start
//	2)define function prime
//	3)declare num,rem,
//	3.1)while(counter<num)
//	3.2)check(rem==0)
//	4) not prime
//	4.1)counter=counter+1
//	4.2)checknum==counter
//	5)go to main function
//	6)accept num
//	7)call the function prime|(num,counter,rem)
//	8)stop
//	
