using System;
using System.Reactive.Linq;
using System.Reactive.Subjects;

namespace EShop.Api.Messaging
{
    public sealed class ProductReviewMessageService
    {
        private readonly ReplaySubject<ProductReviewAddedMessage> _messageStream = new(1);

        public void AddReviewAddedMessage(ProductReviewAddedMessage message)
        {
            _messageStream.OnNext(message);
        }

        public IObservable<ProductReviewAddedMessage> GetMessages()
        {
            return _messageStream.AsObservable();
        }
    }
}
