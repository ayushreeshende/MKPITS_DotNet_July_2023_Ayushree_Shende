#include<stdio.h>
void main()
{
	int cnt=0;
	char name[10];
	char  *ptr;
	printf("enter name");
	gets(name);
	ptr=name;
	while(*ptr!='\0')
	{
		if(*ptr=='a'|| *ptr=='e' || *ptr=='i' ||  *ptr=='o' ||*ptr=='u');
		{
			cnt=cnt+1;
	}
ptr++;
}
printf("no of vowels in a str=%d",cnt);
}


