import Link from 'next/link'
import Logo from '../../img/shamanking.png'

export default function Header() {
	return (
		<header className="header">
			<img src="shamanking.png" alt="logo" />
			<ul>
				<li>
					<Link href="/RotaUm">Home</Link>
				</li>
				<li>
					<Link href="/RotaDois">Destinos</Link>
				</li>
				<li>
					<Link href="/RotaTres">Clientes</Link>
				</li>
			</ul>
		</header>
	)
}