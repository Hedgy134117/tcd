public class CardEffects : MonoBehavior {
  
  // get cards
  public GameObject cardManager;
  private GameObject[] cards;
  
  public string currentCardEffect;
  
  void Start() {
    cards = cardManager.getComponent<cardManager>().cards;
  }
  
  void Update() {
    
    foreach (var card in cards) {
      if(card.tag == "currentCard") {
        currentCardEffect = card.name;
      }
    }
    
  }
  
  void applyEffect(string effect) {
    switch(effect) {
      case "The Absolute Stronk":
        // blah
        break;
    }
  }
  
}