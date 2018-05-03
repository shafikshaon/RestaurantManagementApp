import {Ingredients} from './ingredients.model';
import { FoodItemImage } from './food-item-image.model';

export class FoodItems {
  public Id: string;
  public Name: string;
  public Price: number;
  public MakingCost: number;
  public FoodItemImage: string;
  public Ingredients: Ingredients[];

  constructor(id: string, name: string,  price: number, makingCost: number,
              foodItemImage: string, ingredients: Ingredients[]) {
    this.Id = id;
    this.Name = name;
    this.Price = price;
    this.Ingredients = ingredients;
    this.FoodItemImage = foodItemImage;
    this.MakingCost = makingCost;
  }
}
