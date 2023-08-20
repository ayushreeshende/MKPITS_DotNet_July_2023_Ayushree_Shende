#include<stdio.h>
void main()
{
	char name1[20];
	char name2[20];
	char *ptr1,*ptr2;
	printf("enter any name :");
	gets(name1);
	ptr1=name1;
	ptr2=name2;
	while(*ptr1 !='\0')
	{
		*ptr2=*ptr1;
		ptr1++;
		ptr2++;
		
	}
	*ptr2='\0';
	printf("copy string=%s",name2);
}
