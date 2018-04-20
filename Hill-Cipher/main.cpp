#include <bits/stdc++.h>

using namespace std;
char plaintMessage[3],cipherMessage[3];
int key[3][3],alpha[26],NewMatrix[3][3];
int state,k;
bool vis[3][3]= {};

void  EntryData()
{
    char Message[3];
    printf("Please Enter the Key Matrix 3x3\n");
    for(int i=0; i<3; i++)
        for(int j=0; j<3; j++)
            scanf("%d",&key[i][j]);

    printf("\n=============================\n");
    if(state==1)printf("Please Enter the Plaint Message\n");
    else printf("Please Enter the Cipher Message\n");
    scanf("%s",Message);
    for(int i=0; i<3; i++)
        Message[i]=tolower(Message[i]);
    printf("\n=============================\n");

    if(state==1)copy(begin(Message),end(Message),begin(plaintMessage));
    else copy(begin(Message),end(Message),begin(cipherMessage));
}


void Encrypt()
{

    int tot=0,temp=0;
    for(int i=0; i<3; i++)
    {
        tot=0, temp=0;
        for(int j=0; j<3; j++)
        {
            tot+= alpha[plaintMessage[temp++]-'a'] * key[j][i];
        }
        cipherMessage[i]=(tot %26)+'a';
    }

}


int ValueofMatrix()
{
    int tot=0;
    for(int i=0; i<3; i++)
    {
        int E1y=(i+1>2)? i+1-3:i+1,
            E2y=(i+2>2)? i+2-3:i+2,
            E3y=(i+2>2)? i+2-3:i+2,
            E4y=(i+1>2)? i+1-3:i+1;
        tot+= key[0][i]*(( key[1][E1y] * key[2][E2y] )-( key[2][E4y] * key[1][E3y] ) );

    }
    if(tot<0)tot = ((abs(tot)/26)+1)*26- abs(tot);
    return tot%26;
}
void traverseMatrix()
{
    for(int i=0; i<3; i++)
    {
        for(int j=0; j<3; j++)
        {
            if(i!=j && !vis[i][j])
            {
                swap(key[i][j],key[j][i]);
                vis[i][j]=1;
                vis[j][i]=1;
            }
        }
    }
}

void getNewMatrix()
{
    for(int i=0; i<3; i++)
    {
        for(int j=0; j<3; j++)
        {
            int E1x=(i+1>2)? i+1-3:i+1,
                E1y=(j+1>2)? j+1-3:j+1,
                E2x=(i+2>2)? i+2-3:i+2,
                E2y=(j+2>2)? j+2-3:j+2,
                E3x=(i+1>2)? i+1-3:i+1,
                E3y=(j+2>2)? j+2-3:j+2,
                E4x=(i+2>2)? i+2-3:i+2,
                E4y=(j+1>2)? j+1-3:j+1;
            int  tot = (( key[E1x][E1y] * key[E2x][E2y] )-( key[E3x][E3y] * key[E4x][E4y] ) )*k ;
            if(tot<0) NewMatrix[i][j] =((abs(tot)/26)+1)*26- abs(tot);
            else NewMatrix[i][j] =tot%26;
        }
    }
}

void EncryptToTheMainText()
{
    int tot=0,temp=0;
    for(int i=0; i<3; i++)
    {
        tot=0, temp=0;
        for(int j=0; j<3; j++)
        {
            tot+= alpha[cipherMessage[temp++]-'a'] * NewMatrix[j][i];
        }
        plaintMessage[i]=(tot %26)+'a';
        printf("%c",plaintMessage[i]);
    }
}

void Decryption()
{

    int VofMatrix= ValueofMatrix();

    // get Value K
    for(int i=0; i<26; i++)
        if((VofMatrix*i) % 26 == 1)
        {
            k=i;
            break;
        }
    traverseMatrix();
    getNewMatrix();
    EncryptToTheMainText();
}


int main()
{
    freopen("read.txt","r",stdin);
    for(int i=0; i<26; i++)alpha[i]=i;

    printf("Welcome To Hill-Cipher Application\n================\nEnter 1 for Encryption  ---  Enter 2 for Decryption ----  Enter 0 For Exit\n");
    printf("\n=============================\n\n\n\n");


    while(scanf("%d",&state))
    {
        memset(vis,0,sizeof vis);
        if(state==0)return printf("Thanks For using My Application ^_^\n"),0;
        if(state==1)
        {
            EntryData();
            Encrypt();
            printf("%s\n",cipherMessage);
            printf("\n=============================\n\n\n\n");

        }
        else
        {
            EntryData();
            Decryption();
            printf("\n=============================\n");
        }
    }

}
/*
17 1 3
3 2 3
7 1 4
*/


