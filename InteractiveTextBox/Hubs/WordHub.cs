using InteractiveTextBox;
using Microsoft.AspNetCore.SignalR;
using System.Linq;
using System.Threading.Tasks;

namespace InteractiveTextBox.Hubs
{
    public class WordHub : Hub
    {
        private readonly AppDbContext _context;

        public WordHub(AppDbContext context)
        {
            _context = context;
        }

        public async Task SearchWords(string term)
        {
            var words = _context.Words
                .Where(w => w.Text.StartsWith(term))
                .Select(w => w.Text)
                .Take(10)
                .ToList();

            await Clients.Caller.SendAsync("ReceiveWords", words);
        }
    }
}
