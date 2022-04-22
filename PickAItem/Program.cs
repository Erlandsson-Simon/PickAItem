global using System;

bool gameOver = false;

while (!gameOver) {
    Items.ItemList();
    gameOver = Check.GoAgain();
}
