function maxProfit(prices: number[]): number {

    let minPrice  : number = Infinity;
    let maxProfit : number = 0;

    for(let i=0; i<prices.length; i++) {

        if(prices[i] < minPrice)  minPrice = prices[i];

        let currentProfit = prices[i] - minPrice;

        if(currentProfit > maxProfit) maxProfit = currentProfit;
           
    }

    return maxProfit;
};
