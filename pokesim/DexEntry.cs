using System;

public class DexEntry {
    public int ID { get; set; }
    public required String Name { get; set; }
    public required String Type1 { get; set; }
    public String? Type2 { get; set; }
    public decimal Height { get; set; }
    public decimal Weight { get; set; }
}