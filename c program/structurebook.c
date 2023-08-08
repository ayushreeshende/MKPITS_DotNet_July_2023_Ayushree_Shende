#include<stdio.h>
#include<string.h>
struct book
{
	char title[50];
	char author[50];
	int bookid;
	
};
void main()
{ 
struct book b1;
strcpy(b1.title,"dotnet");
strcpy(b1.author,"ashish");
b1.bookid=123;
printf("title=%s",b1.title);
printf("\nauthor=%s",b1.author);
printf("\nbook id=%d",b1.bookid);
 }



//Algorithm:
//	1)start
//	2)define struct book
//	3)declare title,author,bookid
//	4)declare main function
//	5)struct book b1
//	6)strcpy.b1 title,author,bookid
//	7)print title,author,bookid
//	8)stop
