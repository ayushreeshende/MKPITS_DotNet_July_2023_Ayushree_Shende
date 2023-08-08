//function with parameter and return a value
#include<stdio.h>
int average(float n1,float n2,float n3,float n4,float n5,float add)
{
	float result=add/5.0f;
	return result;
	
}
void main()
{
	float n1,n2,n3,n4,n5,add,result;
	printf("enter 5 no=");
	scanf("%f%f%f%f%f",&n1,&n2,&n3,&n4,&n5);
	add=n1+n2+n3+n4+n5;
	printf("Addition= %f",add);
	result=average(n1,n2,n3,n4,n5,add);
	printf("Average= %f",result);
}
