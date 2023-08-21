
#include<stdio.h>
int addition()
{



int n1,n2;
printf("enter 2 no");
scanf("%d%d",&n1,&n2);
int result=n1+n2;
return result;
}
void main()
{
	char ch='y';
do
	{
int result;
result=addition();
printf("result=%d",result);
printf("do you want to continue,press'y'");
fflush(stdin);
scanf("%c",&ch);
}
while(ch=='y');
}


//Algorithm:
//	1)start
//	2)define function addition
//	3)declare n1,n2 & result
//	5)go to the main function
//	6)result=addition
//	7)print result
//	8)whilech==y
//	9)stop
