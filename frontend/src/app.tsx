import { useState, useEffect } from 'preact/hooks'
import waterstonsLogo from './assets/logo.svg'
import preactLogo from './assets/preact.svg'
import viteLogo from '/vite.svg'
import './app.css'

function CatList() {
  const [cats, setCats] = useState([]);
  const [loading, setLoading] = useState(true);

  useEffect(() => {
    fetch('http://localhost:5075/cats')
      .then((res) => res.json())
      .then((data) => {
        setCats(data);
        setLoading(false);
      })
      .catch((err) => {
        console.error('Error fetching cats:', err);
        setLoading(false);
      });
  }, []);

  if (loading) return <div>Loading...</div>;

  return (
    <ul>
      {cats.map((cat) => (
        <li key={cat.name}>{cat.name}</li>
      ))}
    </ul>
  );
}

export function App() {
  const [count, setCount] = useState(0)

  return (
    <>
      <div>
        <a href="https://vite.dev" target="_blank">
          <img src={waterstonsLogo} class="logo" alt="Waterstons logo" />
        </a>
        <a href="https://preactjs.com" target="_blank">
          <img src={preactLogo} class="logo preact" alt="Preact logo" />
        </a>
      </div>
      <h1>Welcome to the Cats app!</h1>
      <p>The API we fetch from: <a href="http://localhost:5075/cats">http://localhost:5075/cats</a></p>
      <div class="card">
        <CatList />
      </div> 
    </>
  )
}
