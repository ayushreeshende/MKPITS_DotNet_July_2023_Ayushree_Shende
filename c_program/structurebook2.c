#include<stdio.h>
#include<string.h>
struct book
{
	char title[50];
	char author[50];
	int bookid;
	
};
void printbook(struct book b1);
void main()
{
	struct book b1;
	printf("enter title,author,bookid");
	scanf("%s",b1.title);
	scanf("%s",b1.author);
	scanf("%d",&b1.bookid);
	printbook(b1);
}
	void printbook(struct book b1)
	{
	printf("title=%s",b1.title);
	printf("author=%s",b1.author);
	printf("\nbookid=%d",b1.bookid);
}




//Algorithm:
//	1)start
//	2)define structure book
//	3)declare title,author,bookid
//	4)in main function declare struct book b1
//	5)accept title,author,bookid
//	6)call function printbook b1
//	7)declare function printbook(struct book b1)
//	8)print title,author,bookid
//	9)stop
