#include<stdio.h>
#include<string.h>
struct book
{
	char title[50];
	char author[50];
	int bookid;
	
};
void printbook(struct book *ptr);
void main()
{
	struct book b1;
	printf("enter title,author,&bookid");
	scanf("%s",b1.title);
	scanf("%s",b1.author);
	scanf("%d",&b1.bookid);
	printbook(&b1);
}
void printbook(struct book *ptr)
{
printf("title=%s",ptr->title);
printf("author=%s",ptr->author);
printf("bookid=%d",ptr->bookid);
}



Algorithm:
//	1)start
//	2)define structure book
//	3)declare title,author,bookid
//	4)in main function declare struct book *ptr
//	5)accept title,author,bookid
//	6)call function printbook b1
//	7)declare function printbook(struct book *ptr)
//	8)print title,author,bookid
//	9)stop
