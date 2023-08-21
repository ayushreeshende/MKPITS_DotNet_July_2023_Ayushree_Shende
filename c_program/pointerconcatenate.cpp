#include<stdio.h>
int main()
{
	char name1[20];
	char name2[20];
	char *ptr1,*ptr2;
	printf("enter first name :");
	gets(name1);
	printf("enter second name :");
	gets(name2);
	ptr1=name1;
	while(*ptr1 !='\0')
	{
		ptr1++;
	}
	ptr2=name2;
	while(*ptr2 !='\0')
	{
		*ptr1=*ptr2;
		ptr1++;
		ptr2++;
		
	}
	*ptr1='\0';
	printf("concetenate string=%s",name1);
}
