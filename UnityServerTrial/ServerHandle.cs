namespace UnityServerTrial
{
    public class ServerHandle
    {
        public static void WelcomeReceived(int fromClient, Packet packet)
        {
            int clientIdCheck = packet.ReadInt();
            string username = packet.ReadString();
            
            Console.WriteLine($"{Server.clients[fromClient].tcp.socket.Client.RemoteEndPoint} connected successfully and is now play {fromClient}");
            if (fromClient != clientIdCheck)
            {
                Console.WriteLine($"Player \"{username}\" (ID: {fromClient} has assumed the wrong client ID({clientIdCheck})!!!");
            }
            //TODO send player into game
        }

        public static void UDPTestReceived(int fromClient, Packet packet)
        {
            string msg = packet.ReadString();
            
            Console.WriteLine($"Received packet via UDP. Contains message: {msg}");
        }
    }
}