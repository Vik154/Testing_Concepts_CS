﻿// Проблема тестирования с внешней зависимостью 
namespace Projects._001_Problem;

public class TestDataObject {
    public List<string> GetFiles() {
        List<string> list = new List<string>();
        list.Add("file1.txt");
        list.Add("file2.log");
        list.Add("file3.exe");
        return list;
    }
}