using System;

namespace kafkaConsume
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var option = new KafkaNet.Model.KafkaOptions(new Uri(ConfigHelper.Broker));
                var broker = new KafkaNet.BrokerRouter(option);
                var consumerOption = new KafkaNet.Model.ConsumerOptions(ConfigHelper.Topic, broker);

                //设置消费者心跳时间，时间越短，消息约及时
                //不过得考虑实际情况，避免不需要的请求
                consumerOption.MaxWaitTimeForMinimumBytes = new TimeSpan(10);

                var consumer = new KafkaNet.Consumer(consumerOption);
                foreach (var message in consumer.Consume())
                {
                    var value = message.Value;
                    if (value != null)
                        Console.WriteLine(System.Text.Encoding.UTF8.GetString(value));
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}
