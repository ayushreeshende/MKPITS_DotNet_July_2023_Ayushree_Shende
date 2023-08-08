#include<stdio.h>
int main()
{
int m1,m2,m3,total;
float per;
printf("enter 3 subject marks");
scanf("%d,%d,%d",&m1,&m2,&m3);
total=m1+m2+m3;
per=(total/300.0f)*100.0f;
printf("total marks:=%d",total);
printf("\npercentage:=%f",per);
if(per>=75)
{
	printf("\ngrade=A");
} 
else if(per<75&&per>=68)
{
	printf("\n grade=B");
}
else if (per<60 && per>=40)
{
	printf("\n grade=C");
}
		else
		{
			printf("\n fail");
		}
		return 0;
	}


