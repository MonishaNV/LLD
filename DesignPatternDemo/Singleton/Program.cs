// See https://aka.ms/new-console-template for more information
using Singleton;
Logger l1 = Logger.Instance;
l1.LogMessage("logged message");

Logger l2 = Logger.Instance;
l2.LogMessage("logged 2nd message.");

