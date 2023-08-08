
#include<stdio.h>
int average()
{
	float n1,n2,n3,n4,n5,add;
	float result;
	printf("enter 5 no=");
	scanf("%f%f%f%f%f",&n1,&n2,&n3,&n4,&n5);
	add=n1+n2+n3+n4+n5;
	printf("Addition of 5 no = %f\n",add);
	result=add/5;
	return result;
}
void main()
{
	float result;
	result=average();
	printf("average = %f",result);
}




//Algorithm:
//	1)start
//	2)define the function average
//	3)declare float ,result,add
//	4)accept 5 no
//	5)print add of no
//	6)result
//	7)go the main function
//	8)result=average
//	9)print average &result
//	10)stop
