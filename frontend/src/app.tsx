import { useState, useEffect } from 'preact/hooks'
import preactLogo from './assets/preact.svg'
import dotnetLogo from './assets/dotnet.png'
import './assets/light.css'
import './app.css'

interface Cat {
  name: string;
}

interface CatListProps {
  count: number;
}

function CatList({ count }: CatListProps) {
  const [cats, setCats] = useState<Cat[]>([]);
  const [loading, setLoading] = useState(true);

  useEffect(() => {
    fetch('http://localhost:5075/cats')
      .then((res) => res.json())
      .then((data: Cat[]) => {
        setCats(data);
        setLoading(false);
      })
      .catch(() => setLoading(false));
  }, []);

  if (loading) return <div>Loading...</div>;

  return (
    <ul>
      {cats.slice(0, count).map((cat) => (
        <li key={cat.name}>{cat.name}</li>
      ))}
    </ul>
  );
}

export function App() {
  const [count, setCount] = useState(3);

  return (
    <>
      <div class="builtWith">
        <h2>This app is built with:</h2>
        <a href="https://preactjs.com" target="_blank">
          <img src={preactLogo} alt="Preact logo" />
        </a>
        <a href="https://dotnet.microsoft.com/en-us/apps/aspnet" target="_blank">
          <img src={dotnetLogo} alt="ASP.NET Core logo" />
        </a>
      </div>

      <main>
        <h1>Welcome to the Cats app!</h1>
        <p>The API we fetch from: <a href="http://localhost:5075/cats">http://localhost:5075/cats</a></p>

        <div class="card">
          <span >You have: {count} cats</span>
          <p>More cats?</p>
          <button onClick={() => setCount((c) => Math.max(c - 1, 0))}>-</button>
          <button onClick={() => setCount((c) => c + 1)}>+</button>
          <CatList count={count} />
        </div>
      </main>
    </>
  )
}
