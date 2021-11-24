# Chalenge Votorantim

Pré-requisito: MongoDB rodando.

#Instruções de uso

Alterar a string de conexão do MongoDB para a conexão do banco instalado, ex: "mongodb://admin:admin@localhost:27017"

Rodar a aplicação e realizar os cadastro necessários.

Device - Cadastro dos sensores.

Truck - Cadastro do caminhão/Motorista.

Dock - Cadastro dos pontos finais ou as docas que os motoristas irão parar. Necessita ter os devices cadastrados.
Os códigos de dirção são os seguintes: 0 - Direita, 1 - Esquerda, 2 - Frente.

Tickets - Cadastra um caminhão para uma doca. Só precisa colocar o Id do caminhão e da doca.

Transport - Este endpoint mostra onde oo caminhão está na rota, simula ele passando por um sensor.
Deve-se colocar apenas o Id do Ticket e do Device.
