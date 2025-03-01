#include "Files.h"

int main()
{
    File workWithFiles;
    FileASCII workWithFilesASCII;
    FileBit workWithFilesBit;
    //FileDuoble workWithFilesDouble;
    string path = "test.txt";

    workWithFiles.Display(path);
    workWithFilesASCII.Display(path);
    workWithFilesBit.Display(path);
}
