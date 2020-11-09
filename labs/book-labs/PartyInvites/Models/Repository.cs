using System.Collections.Generic;

namespace PartyInvites.Models
{
    public static class Repository
    {
        private static List<GuestResponse> responses = new List<GuestResponse>(); //create a field (DO not have implementation)
        public static IEnumerable<GuestResponse> Responses => responses; //Property
        public static void AddResponse(GuestResponse response) //Method
        {
            responses.Add(response); //Adds an object to the end of the List, and come from the "List"
        }
    }
}