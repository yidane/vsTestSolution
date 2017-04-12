using KafkaNet.Model;
using System;

namespace kafkaProduce
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("kafka produce begin");

                var option = new KafkaOptions(new Uri(ConfigHelper.Broker));
                var router = new KafkaNet.BrokerRouter(option);
                KafkaNet.Producer producer = new KafkaNet.Producer(router);
                var topic = ConfigHelper.Topic;
                while (true)
                {
                    var now = DateTime.Now.ToString("yyyy-MM-dd hh:MM:ss");
                    var message = new[] { new KafkaNet.Protocol.Message($"Send Message To Consume: {now}") };
                    producer.SendMessageAsync(topic, message).Wait(2000);

                    Console.WriteLine($"    Message Produce: {now}");

                    System.Threading.Thread.Sleep(800);
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}