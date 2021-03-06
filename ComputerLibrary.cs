using System;

namespace Problem2
{
    public class ComputerLibrary
    {
        public class HardDrive
        {
            int capacity;
            string type;
            int readSpeed;
            int writeSpeed;

            public HardDrive(int capacity, string type,
                int readSpeed, int writeSpeed)
            {
                this.capacity = capacity;
                this.type = type;
                this.readSpeed = readSpeed;
                this.writeSpeed = writeSpeed;
            }

            public override string ToString()
            {
                return "HardDrive;" + capacity + " " + type + " " + readSpeed + " " + writeSpeed;
            }

            public int Capacity
            {
                get { return capacity; }
                set
                {
                    capacity = value;
                    if (capacity < 0)
                        throw new Exception("capacity cannot be zero.");
                    if (capacity > 1500)
                        throw new Exception("too many capacity");
                }
            }

            public string Type
            {
                get { return type; }
                set
                {
                    type = value;
                    if (type == "")
                        throw new Exception("type cannot be empty.");
                    if (type.Length > 20)
                        throw new Exception("too many characters");
                }
            }

            public int ReadSpeed
            {
                get { return readSpeed; }
                set
                {
                    readSpeed = value;
                    if (readSpeed < 0)
                        throw new Exception("readSpeed cannot be zero.");
                    if (readSpeed > 1500)
                        throw new Exception("too many readSpeed");
                }
            }

            public int WriteSpeed
            {
                get { return writeSpeed; }
                set
                {
                    writeSpeed = value;
                    if (writeSpeed < 0)
                        throw new Exception("writeSpeed cannot be zero.");
                    if (writeSpeed > 1500)
                        throw new Exception("too many writeSpeed");
                }
            }
        }//end of hard drive

        public class Motherboard
        {
            int memorySlots;
            int powerConsumption;
            int pciSlots;
            string formFactor;
            int hardDriveLimit;
            string cpu;
            int memory;
            string graphicsCard;

            public Motherboard(int memorySlots, int powerConsumption,
                int pciSlots, string formFactor, int hardDriveLimit, string cpu,
                int memory, string graphicsCard)
            {
                this.memorySlots = memorySlots;
                this.powerConsumption = powerConsumption;
                this.pciSlots = pciSlots;
                this.formFactor = formFactor;
                this.hardDriveLimit = hardDriveLimit;
                this.cpu = cpu;
                this.memory = memory;
                this.graphicsCard = graphicsCard;
            }

            public override string ToString()
            {
                return "Motherboard;" + memorySlots + " " + powerConsumption + " " + pciSlots +
                    " " + formFactor + " " + hardDriveLimit + " " + cpu + " " + memory + " " +
                    graphicsCard;
            }

            public int MemorySlots
            {
                get { return memorySlots; }
                set
                {
                    memorySlots = value;
                    if (memorySlots < 0)
                        throw new Exception("memory slots cannot be zero.");
                    if (memorySlots > 20)
                        throw new Exception("too many memory slots");
                }
            }

            public int PowerConsumption
            {
                get { return powerConsumption; }
                set
                {
                    powerConsumption = value;
                    if (powerConsumption < 0)
                        throw new Exception("Power Consumption cannot be zero.");
                    if (powerConsumption > 1500)
                        throw new Exception("too many Power Consumption");
                }
            }

            public int PciSlots
            {
                get { return pciSlots; }
                set
                {
                    pciSlots = value;
                    if (pciSlots < 0)
                        throw new Exception("pciSlots cannot be zero.");
                    if (pciSlots > 1500)
                        throw new Exception("too many pciSlots");
                }
            }

            public string FormFactor
            {
                get { return formFactor; }
                set
                {
                    formFactor = value;
                    if (formFactor == "")
                        throw new Exception("formFactor cannot be empty.");
                    if (formFactor.Length > 20)
                        throw new Exception("too many characters");
                }
            }
            public int HardDriveLimit
            {
                get { return hardDriveLimit; }
                set
                {
                    hardDriveLimit = value;
                    if (hardDriveLimit < 0)
                        throw new Exception("hardDriveLimit cannot be zero.");
                    if (hardDriveLimit > 20)
                        throw new Exception("hard drive exceeds limit");
                }
            }
            public string Cpu
            {
                get { return cpu; }
                set
                {
                    cpu = value;
                    if (cpu == "")
                        throw new Exception("cpu cannot be empty.");
                    if (cpu.Length > 20)
                        throw new Exception("too many characters");
                }
            }
            public int Memory
            {
                get { return memory; }
                set
                {
                    memory = value;
                    if (memory < 0)
                        throw new Exception("memory cannot be empty.");
                    if (memory > 20)
                        throw new Exception("too much memory");
                }
            }
            public string GraphicsCard
            {
                get { return graphicsCard; }
                set
                {
                    graphicsCard = value;
                    if (graphicsCard == "")
                        throw new Exception("graphicsCard cannot be empty.");
                    if (graphicsCard.Length > 20)
                        throw new Exception("too many characters");
                }
            }

        }//end of motherboard

        public class CPU
        {
            double speed;
            string manufacturer;
            string socketType;
            int cachesize;
            int numberofCores;


            public CPU(double speed, string manufacturer,
                 string socketType, int cachesize, int numberofCores)
            {
                this.speed = speed;
                this.manufacturer = manufacturer;
                this.socketType = socketType;
                this.cachesize = cachesize;
                this.numberofCores = numberofCores;
            }

            public override string ToString()
            {
                return "CPU;" + speed + " " + manufacturer + " " + socketType + " " +
                    cachesize + " " + numberofCores;
            }

            public double Speed
            {
                get { return speed; }
                set
                {
                    speed = value;
                    if (speed < 0)
                        throw new Exception("speed cannot be zero.");
                    if (speed > 1500)
                        throw new Exception("too many speed");
                }
            }
            public string Manufacturer
            {
                get { return manufacturer; }
                set
                {
                    manufacturer = value;
                    if (manufacturer == "")
                        throw new Exception("manufacturer cannot be zero.");
                    if (manufacturer.Length > 30)
                        throw new Exception("too many manufacturer");
                }
            }
            public string SocketType
            {
                get { return socketType; }
                set
                {
                    socketType = value;
                    if (socketType == "")
                        throw new Exception("socketType cannot be zero.");
                    if (socketType.Length > 30)
                        throw new Exception("too many socketType");
                }
            }
            public int Cachesize
            {
                get { return cachesize; }
                set
                {
                    cachesize = value;
                    if (cachesize < 0)
                        throw new Exception("cachesize cannot be zero.");
                    if (cachesize > 1500)
                        throw new Exception("too many cachesize");
                }
            }
            public int NumberofCores
            {
                get { return numberofCores; }
                set
                {
                    numberofCores = value;
                    if (numberofCores < 0)
                        throw new Exception("numberofCores cannot be zero.");
                    if (numberofCores > 1500)
                        throw new Exception("too many numberofCores");
                }
            }
        }// end of cpu

        public class Memory
        {
            double readSpeed;
            double writeSpeed;
            string type;
            int amountGb;

            public Memory(double readSpeed, double writeSpeed,
                string type, int amountGb)
            {
                this.readSpeed = readSpeed;
                this.writeSpeed = writeSpeed;
                this.type = type;
                this.amountGb = amountGb;
            }

            public override string ToString()
            {
                return "Memory;" + readSpeed + " " + writeSpeed + " " + type +
                    " " + amountGb;
            }

            public double ReadSpeed
            {
                get { return readSpeed; }
                set
                {
                    readSpeed = value;
                    if (readSpeed < 0)
                        throw new Exception("readSpeed cannot be zero.");
                    if (readSpeed > 1500)
                        throw new Exception("too many readSpeed");
                }
            }
            public double WriteSpeed
            {
                get { return writeSpeed; }
                set
                {
                    writeSpeed = value;
                    if (writeSpeed < 0)
                        throw new Exception("writeSpeed cannot be zero.");
                    if (writeSpeed > 1500)
                        throw new Exception("too many writeSpeed");
                }
            }

            public string Type
            {
                get { return type; }
                set
                {
                    type = value;
                    if (type == "")
                        throw new Exception("type cannot be empty.");
                    if (type.Length > 20)
                        throw new Exception("too many characters");
                }
            }

            public int AmountGb
            {
                get { return amountGb; }
                set
                {
                    amountGb = value;
                    if (amountGb < 0)
                        throw new Exception("amountGb cannot be zero.");
                    if (amountGb > 1500)
                        throw new Exception("too many amountGb");
                }
            }
        }// end of memory

        public class GraphicsCard
        {
            int fanCount;
            double speed;
            int videoMemory;
            int numberCUDAcores;

            public GraphicsCard(int fanCount, double speed,
                int videoMemory, int numberCUDAcores)
            {
                this.fanCount = fanCount;
                this.speed = speed;
                this.videoMemory = videoMemory;
                this.numberCUDAcores = numberCUDAcores;
            }

            public override string ToString()
            {
                return "GraphicsCard;" + fanCount + " " + speed + " " + videoMemory +
                    " " + numberCUDAcores;
            }

            public int FanCount
            {
                get { return fanCount; }
                set
                {
                    fanCount = value;
                    if (fanCount < 0)
                        throw new Exception("fanCount cannot be zero.");
                    if (fanCount > 1500)
                        throw new Exception("too many fanCount");
                }
            }
            public double Speed
            {
                get { return speed; }
                set
                {
                    speed = value;
                    if (speed < 0)
                        throw new Exception("speed cannot be zero.");
                    if (speed > 1500)
                        throw new Exception("too many speed");
                }
            }
            public int VideoMemory
            {
                get { return videoMemory; }
                set
                {
                    videoMemory = value;
                    if (videoMemory < 0)
                        throw new Exception("videoMemory cannot be zero.");
                    if (videoMemory > 1500)
                        throw new Exception("too many videoMemory");
                }
            }
            public int NumberCUDAcores
            {
                get { return numberCUDAcores; }
                set
                {
                    numberCUDAcores = value;
                    if (numberCUDAcores < 0)
                        throw new Exception("numberCUDAcores cannot be zero.");
                    if (numberCUDAcores > 1500)
                        throw new Exception("too many numberCUDAcores");
                }
            }
        }// end of graphics card

        public class Case
        {
            int length;
            int width;
            int height;
            int numberFans;
            int numberVents;

            public Case(int length, int width,
                int height, int numberFans, int numberVents)
            {
                this.length = length;
                this.width = width;
                this.height = height;
                this.numberFans = numberFans;
                this.numberVents = numberVents;
            }

            public override string ToString()
            {
                return "Case;" + length + " " + width + " " + height +
                    " " + numberFans + " " + numberVents;
            }


            public int Length
            {
                get { return length; }
                set
                {
                    length = value;
                    if (length < 0)
                        throw new Exception("length cannot be zero.");
                    if (length > 1500)
                        throw new Exception("too many length");
                }
            }

            public int Width
            {
                get { return width; }
                set
                {
                    width = value;
                    if (width < 0)
                        throw new Exception("width cannot be zero.");
                    if (width > 1500)
                        throw new Exception("too many width");
                }
            }

            public int Height
            {
                get { return height; }
                set
                {
                    height = value;
                    if (height < 0)
                        throw new Exception("height cannot be zero.");
                    if (height > 1500)
                        throw new Exception("too many height");
                }
            }

            public int NumberFans
            {
                get { return numberFans; }
                set
                {
                    numberFans = value;
                    if (numberFans < 0)
                        throw new Exception("numberFans cannot be zero.");
                    if (numberFans > 1500)
                        throw new Exception("too many numberFans");
                }
            }

            public int NumberVents
            {
                get { return numberVents; }
                set
                {
                    numberVents = value;
                    if (numberVents < 0)
                        throw new Exception("numberVents cannot be zero.");
                    if (numberVents > 1500)
                        throw new Exception("too many numberVents");
                }
            }
        }// end of case

    }// end of library
}
