
using testClicknext.src;

class Program
{
    static void Main()
    {
        //ข้อ 1 จับคู่ตัวแรก
        SumCalculator calculator = new SumCalculator();
        calculator.CalSum();

        // ข้อ 2 ตรวจสอบความเหมือน
        StringsEqual stringsEqual = new StringsEqual();

        Console.WriteLine(stringsEqual.AreStringsEqual("palM", "malp"));

        //ข้อ 3 จัดช่วงวันออกอากาศ
        RangeOfDay rangeOfDay = new RangeOfDay();
        Console.WriteLine(rangeOfDay.RangeDay(new int[] { 1, 4, 6, 9, 10, 11, 16, 17, 18, 19 }));

        //ข้อ 4 วาดสามเหลี่ยมด้วย * กลับหัว
        DrawTriangle drawTriangle = new DrawTriangle();
        drawTriangle.drawTriangle4(4);
        //ข้อ 5 วาดสามเหลี่ยมด้วยตัวเลข
        drawTriangle.drawTriangle5(4);
        //ข้อ 10 วาดสามเหลี่ยมด้วย * หัวตั้ง
        drawTriangle.drawTriangle10(4);


        //ข้อ 6 และ 11 เรียกลำดับจากมากน้อยเลือกให้ Selection Sort 

        Sorting sorting = new Sorting();
        sorting.sortMaxtoMin(new int[] { 1, 4, 6, 9, 10, 11, 16, 17, 18, 19 });
        sorting.sortMintoMax(new int[] { 10, 4, 6, 9, 10, 11, 16, 17, 18, 19 });

        //ข้อ 7 แปลง วินาที เป็น ชั่วโมง:นาที:วินาที
        ConvertSecondsToTime convertSecondsToTime = new ConvertSecondsToTime();
        Console.WriteLine(convertSecondsToTime.secondsToTime(6));

        // ข้อ 8 คำนวนเงินทอน
        ChangeCalculate changeCalculate = new ChangeCalculate();
        changeCalculate.CalculateChange();

        //ข้อ 9 reverse คำ

        Reverse reverse = new Reverse();
        reverse.ReverseWords("Korawi Bunyuen palm");


    }



}
