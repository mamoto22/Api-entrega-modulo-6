import styles from './card.module.css';

const card ={
	id: 1,
	title: 'Card',
	description: 'A card componet',
	cardURL:"https://upload.wikimedia.org/wikipedia/commons/b/bc/Unknown_person.jpg"
}


export default async function Card() {
	const cards = await fetch('http://localhost:5132/api/Cliente').then(res => res.json());
	console.log(cards);

	return (
		<div>
		<div className={styles.container}>
			{cards?.map((card) => (
				<div key={card.id} className={styles.card}>
						<p>nome:{card.name}</p>
						<p>telefone:{card.telefone}</p>
						<p>Idade:{card.idade}</p>
					
				</div>
			))}
		</div>

	</div>	
	)
}
