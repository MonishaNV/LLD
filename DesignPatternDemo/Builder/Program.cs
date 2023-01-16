using System;

namespace Builder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Builder dellDesktopBuilder = new DellDesktopBuilder();
            Builder hpDesktopBuilder = new HPDesktopBuilder();

            DesktopBuildDirector d1 = new DesktopBuildDirector(hpDesktopBuilder);
            d1.BuildDesktop();
            DesktopBuildDirector d2 = new DesktopBuildDirector(dellDesktopBuilder);
            d2.BuildDesktop();

            Desktop desktop1 = d1.GetDesktop();
            desktop1.ShowSpec();

            Desktop desktop2 = d2.GetDesktop();
            desktop2.ShowSpec();
        }
    }

    class Desktop
    {
        public string? CPU { private get; set; }
        public string? Keyboard { private get; set; }
        public string? Monitor { private get; set; }
        public string? Mouse { private get; set; }

        public void ShowSpec()
        {
            Console.WriteLine(CPU);
            Console.WriteLine(Monitor);
            Console.WriteLine(Keyboard);
            Console.WriteLine(Mouse);

        }
    }
    class Builder
    {
        public Desktop desktop { get; set; }
        public Builder() { desktop = new Desktop(); }
        public virtual void BuildCPU() { }
        public virtual void BuildMonitor() { }
        public virtual void BuildKeyboard() { }
        public virtual void BuildMouse() { }
        public virtual void ShowSpec() { }
    }

    class DellDesktopBuilder : Builder
    {
        public override void BuildCPU() { desktop.CPU = "DEll CPU is built"; }
        public override void BuildMonitor() { desktop.Monitor = "DEll Monitor is built"; }
        public override void BuildMouse() { desktop.Mouse = "DEll  mouse is built"; }
        public override void BuildKeyboard() { desktop.Keyboard = "DEll keyboard is built"; }
        public void ShowSpecs() { desktop.ShowSpec(); }
    }

    class HPDesktopBuilder : Builder
    {
        public override void BuildCPU() { desktop.CPU = "HP CPU is built"; }
        public override void BuildMonitor() { desktop.Monitor = "HP Monitor is built"; }
        public override void BuildMouse() { desktop.Mouse = "HP  mouse is built"; }
        public override void BuildKeyboard() { desktop.Keyboard = "HP keyboard is built"; }
        public void ShowSpecs() { desktop.ShowSpec(); }

    }

    class DesktopBuildDirector
    {
        Builder builder;
        public DesktopBuildDirector(Builder pBuilder) { builder = pBuilder; }
        public void BuildDesktop()
        {
            builder.BuildCPU();
            builder.BuildKeyboard();
            builder.BuildMonitor();
            builder.BuildMouse();
            builder.ShowSpec();
        }
        public Desktop GetDesktop() { return builder.desktop; }
    }
}
