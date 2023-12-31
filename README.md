# Tratamento de Erros com `Try`, `Catch` e `Finally`

Objetivo:
Este código de exemplo demonstra como usar as construções `try`, `catch` e `finally` em C# para lidar com erros em um programa. O objetivo é ilustrar como proteger o programa contra exceções que podem ocorrer durante a execução, mantendo o controle do fluxo do programa e garantindo ações de limpeza, se necessário.

Processo do Código:
1. O código apresenta uma aplicação Windows Forms simples.
2. Quando o botão é clicado, ele tenta executar um bloco de código no `try`.
3. No `try`, há um loop que concatena elementos de um array de inteiros em uma string.
4. Se uma exceção ocorrer durante o loop, o fluxo de controle passará para o bloco `catch`.
5. No `catch`, a exceção é capturada e uma mensagem de erro é exibida na etiqueta.
6. Independentemente de ocorrer uma exceção ou não, o bloco `finally` é executado, mostrando uma mensagem de conclusão da operação.

Como Usar:
1. Abra a aplicação.
2. Clique no botão para executar o código de exemplo.
3. Observe como o tratamento de erros é usado para lidar com exceções e como a mensagem de conclusão sempre é exibida.

Observações:
- O uso de `try`, `catch` e `finally` é importante para garantir que um programa não falhe completamente em caso de erros e também para permitir ações de limpeza, como a liberação de recursos, antes que o programa termine.
- É importante capturar exceções específicas sempre que possível para tratar diferentes tipos de erros de maneira adequada.
- O `finally` é usado para ações que devem ser executadas, independentemente de ocorrerem exceções ou não, como fechar arquivos ou conexões de banco de dados.

# pseudocódigo:
```
INÍCIO DO PROGRAMA
    Inicializar a interface gráfica do Windows Forms (Form1)
    
    FUNÇÃO aoClicarNoBotão
        Crie um array de números inteiros chamado "num" com os valores { 10, 20, 30, 40, 50 }
        
        TENTE FAZER O SEGUINTE:
            Inicialize uma variável de texto chamada "res" com uma string vazia
            PARA cada valor "i" de 0 a 4 FAÇA
                Adicione o valor "num[i]" à string "res", seguido de um espaço
            FIM DO LOOP
            Exiba a string resultante "res" na etiqueta "label1"
        
        PEGUE QUALQUER EXCEÇÃO QUE OCORRER E FAÇA O SEGUINTE:
            Exiba uma mensagem de erro que inclua a mensagem da exceção na etiqueta "label1"
        
        FINALMENTE, FAÇA O SEGUINTE:
            Exiba uma caixa de diálogo com a mensagem "Operação finalizada."
        FIM DO BLOCO TRY-CATCH-FINALLY

FIM DO PROGRAMA
