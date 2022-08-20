Console.WriteLine("Input number of week");
int dayOfWeek=Convert.ToInt32(Console.ReadLine());

if (dayOfWeek==1){
    Console.WriteLine(dayOfWeek + " day of week is Monday");
}
else if (dayOfWeek==2){
    Console.WriteLine(dayOfWeek + " day of week is Tuersday");
}
else if (dayOfWeek==3){
    Console.WriteLine(dayOfWeek + " day of week is Wensday");
}
else if (dayOfWeek==4){
    Console.WriteLine(dayOfWeek + " day of week is Tursday");
}
else if (dayOfWeek==5){
    Console.WriteLine(dayOfWeek + " day of week is Friday");
}
else if (dayOfWeek==6){
    Console.WriteLine(dayOfWeek + " day of week is Saturday");
}
else if (dayOfWeek==7){
    Console.WriteLine(dayOfWeek + " day of week is Sunday");
}
else {
    Console.WriteLine(dayOfWeek + " this day of week doesn't exist");
}